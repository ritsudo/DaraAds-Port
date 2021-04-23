﻿using DaraAds.Domain.Shared.Exceptions;
namespace DaraAds.Application.Services.Message.Contracts.Exceptions
{
    public class HaveNoRigthToGetMessageByChatException : NoRightException
    {
        public HaveNoRigthToGetMessageByChatException(string message) : base(message)
        {
        }
    }
}
