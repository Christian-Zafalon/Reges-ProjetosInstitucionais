import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ComponentComponent } from './component/component.component';
import { ProdutosComponent } from './produtos/produtos.component';

const routes: Routes = [
  {path: 'manter-cliente', component: ComponentComponent},
  {path: 'lista-produtos', component: ProdutosComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
