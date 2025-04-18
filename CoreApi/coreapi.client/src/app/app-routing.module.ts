import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { CategoryComponent } from './category/category.component';

const routes: Routes = [{ path: 'category', component: CategoryComponent },
  { path: '', redirectTo: '/category', pathMatch: 'full' }, // Default route
  { path: '**', redirectTo: '/category' } // Fallback route
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
