import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HomeComponent } from './home/home.component';
import { BuyerAuthComponent } from './buyer-auth/buyer-auth.component';

const routes: Routes = [
  {
    component: HomeComponent,
    path: '',
  },
  {
    component: BuyerAuthComponent,
    path: 'buyer-auth',
  },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule],
})

export class AppRoutingModule {}
