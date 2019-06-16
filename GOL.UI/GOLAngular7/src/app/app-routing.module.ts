import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { AirplaneAddComponent } from './airplane-add/airplane-add.component';
import { AirplaneEditComponent } from './airplane-edit/airplane-edit.component';
import { AirplaneGetComponent } from './airplane-get/airplane-get.component';

const routes: Routes = [  {
  path: 'airplane/create',
  component: AirplaneAddComponent
},
{
  path: 'airplane/edit/:id',
  component: AirplaneEditComponent
},
{
  path: 'airplane',
  component: AirplaneGetComponent
}];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
