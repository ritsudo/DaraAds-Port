import { Component, OnInit } from '@angular/core';
import { SignalrService } from '../../../services/signalr.service';
import { ChatService } from '../../../services/chat.service';
import { CookieService } from 'ngx-cookie-service';
import { Chat, ChatMessage, Message, MessageResponse } from '../../../Dtos/chat';
import { UserService } from '../../../services/user.service';
import { Text } from '@angular/compiler';

@Component({
    selector: 'app-userChats',
    templateUrl: './userChats.component.html',
    styleUrls: ['./userChats.component.scss']
})
export class UserChatsComponent implements OnInit {
    userId = '';
    currentChatId = 0;
    currentRecipientId = ' ';
    isSeller = false;
    chats: Chat[] = [];
    messages: ChatMessage[] = [];

    constructor(private signalrService: SignalrService,
        private chatService: ChatService,
        private cookieService: CookieService,
        private userService: UserService) { }

    ngOnInit() {
        this.signalrService.startConnection();
        this.signalrService.on('message', (message: Message) => this._handleMessage(message));

        this.getChats();

        const username = this.cookieService.get('AuthUsername');
        this.userService.getUser(username).subscribe((data) => {
            this.userId = data.id;
        });
    }

    private _handleMessage = (message: Message) => {
        const chatMessage = {
            text: message.text,
            senderName: message.senderName,
            createdDate: message.createdDate,
            sender: { id: message.senderId },
            recipient: { id: message.recipientId }
        } as ChatMessage;
        this.messages.push(chatMessage);
    }

    getChatMessages(chatId: number): void {
        this.currentChatId = chatId;
        this.chatService.getMessage(chatId).subscribe((data) => {
            this.messages = data.messages!;
        });
    }

    sendMessage(text: string) {
        this.chatService.sendMessage(this.currentChatId, this.currentRecipientId, text).subscribe();
    }

    getCurrentRecipient(recipientId: string) {
        this.currentRecipientId = recipientId;
    }

    chatSeller() {
        this.isSeller = true;
        this.getChats();
    }

    chatRecipient() {
        this.isSeller = false;
        this.getChats();
    }

    getChats() {
        this.chatService.getChats(this.isSeller).subscribe((data) => {
            this.chats = data.chats!;
        });
    }
}
