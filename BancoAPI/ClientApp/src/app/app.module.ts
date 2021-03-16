import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { CadastroContaComponent } from './CadastroConta/cadastroConta.component';
import { ListagemContaComponent } from './ListagemConta/listagemConta.component';

import { CadastroContaService } from './CadastroConta/cadastroConta.service';  

@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    CadastroContaComponent,
    ListagemContaComponent,
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    ReactiveFormsModule,
    RouterModule.forRoot([
      { path: '', component: CadastroContaComponent, pathMatch: 'full' },
      { path: 'listagemConta', component: ListagemContaComponent },
    ])
  ],
  providers: [CadastroContaService],
  bootstrap: [AppComponent]
})
export class AppModule { }
