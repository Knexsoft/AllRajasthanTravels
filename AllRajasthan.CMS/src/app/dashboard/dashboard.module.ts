import { ModuleWithProviders, NgModule } from '@angular/core';
import { RouterModule } from '@angular/router';

import { DashboardComponent } from './dashboard.component';
import { DashboardRoutingModule } from './dashboard-routing.module';
//import { SharedModule } from '../shared';

@NgModule({
  imports: [
    //SharedModule,
    DashboardRoutingModule
  ], 
  declarations: [
    DashboardComponent
  ],
  providers: [
    //HomeAuthResolver
  ]
})
export class DashboardModule { }
