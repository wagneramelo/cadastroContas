import { Component } from '@angular/core';
import { CadastroContaService } from '../CadastroConta/cadastroConta.service';

@Component({
  selector: 'app-listagem-conta-component',
  templateUrl: './listagemConta.component.html'
})
export class ListagemContaComponent {
  constructor(private CadastroContaService: CadastroContaService) { }
  data: any;
  ngOnInit() {
    this.getdata();
  }

  getdata() {
    this.CadastroContaService.getData().subscribe((data: any[]) => {
      this.data = data;
    })
  }
 
}
