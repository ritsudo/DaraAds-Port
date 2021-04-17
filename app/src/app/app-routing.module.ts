import { UserProfilePersonalComponent } from './layout/user/userProfile/userProfilePersonal/userProfilePersonal.component';
import { EditAdvertisementPageComponent } from './layout/advertisement/editAdvertisementPage/editAdvertisementPage.component';
import { NewAdvertisementPageComponent } from './layout/advertisement/newAdvertisementPage/newAdvertisementPage.component';
import { AdvertisementDetailPageComponent } from './layout/advertisement/advertisementDetailPage/advertisementDetailPage.component';
import { NewAbusePageComponent } from './layout/abuse/newAbusePage/newAbusePage.component';
import { AbusePageComponent } from './layout/abuse/abusePage/abusePage.component';
import { ContactsComponent } from './layout/contacts/contacts.component';
import { HelpComponent } from './layout/help/help.component';
import { LoginPageComponent } from './layout/auth/loginPage/loginPage.component';
import { RegistrationPageComponent } from './layout/auth/registrationPage/registrationPage.component';
import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AdvertisementPageComponent } from './layout/advertisement/advertisementPage/advertisementPage.component';
import { PublicProfileComponent } from './layout/user/publicProfile/publicProfile.component';
import { UserProfileComponent } from './layout/user/userProfile/userProfile.component';
import { UserProfileSettingsComponent } from './layout/user/userProfile/userProfileSettings/userProfileSettings.component';
import { UserProfileAdvertisementsComponent } from './layout/user/userProfile/userProfileAdvertisements/userProfileAdvertisements.component';
import { UserProfileLoginPassComponent } from './layout/user/userProfile/userProfileLoginPass/userProfileLoginPass.component';
import { AdvertisementPageWithSubCategoriesComponent } from './layout/advertisement/advertisementPageWithSubCategories/advertisementPageWithSubCategories.component';
import { ForgotPasswordPageComponent } from './layout/auth/forgotPasswordPage/forgotPasswordPage.component';
import { ResetPasswordPageComponent } from './layout/auth/resetPasswordPage/resetPasswordPage.component';

const routes: Routes = [
    // { path: '**', component: PageNotFoundComponent }
    { path: '', component: AdvertisementPageComponent },
    { path: 'registration', component: RegistrationPageComponent },
    { path: 'autorization', component: LoginPageComponent },
    { path: 'help', component: HelpComponent },
    { path: 'contact', component: ContactsComponent },
    { path: 'abuse', component: AbusePageComponent },
    { path: 'newAbuse', component: NewAbusePageComponent },
    { path: 'advertisements', component: AdvertisementPageComponent },
    { path: 'advertisements/:id', component: AdvertisementPageComponent },
    { path: 'filtered_advertisements/:id', component: AdvertisementPageWithSubCategoriesComponent },
    { path: 'advertisement/:id', component: AdvertisementDetailPageComponent },
    { path: 'newAdvertisement', component: NewAdvertisementPageComponent },
    { path: 'editAdvertisement/:id', component: EditAdvertisementPageComponent },
    { path: 'forgotPassword', component: ForgotPasswordPageComponent },
    { path: 'resetPassword', component: ResetPasswordPageComponent },
    { path: 'profile/:Username', component: PublicProfileComponent },
    {
        path: 'cabinet',
        component: UserProfileComponent,
        children: [
            {
                path: 'personal',
                component: UserProfilePersonalComponent,
            },
            {
                path: 'changeinfo',
                component: UserProfileLoginPassComponent,
            },
            {
                path: 'advertisements',
                component: UserProfileAdvertisementsComponent,
            },
            {
                path: 'settings',
                component: UserProfileSettingsComponent,
            },
        ],
    },
];

@NgModule({
    imports: [RouterModule.forRoot(routes)],
    exports: [RouterModule],
})
export class AppRoutingModule { }
