import { Component } from '@angular/core';
import { CadastroContaService } from './cadastroConta.service';
import { FormGroup, FormControl, Validators } from '@angular/forms';

@Component({
  selector: 'app-cadastro-conta',
  templateUrl: './cadastroConta.component.html',
})

export class CadastroContaComponent {
  title = 'Cadastro Conta';
  constructor(private CadastroContaService: CadastroContaService) { }
  data: any;
  ContaForm: FormGroup;
  submitted = false;
  EventValue: any = "Salvar";
  ngOnInit(): void {
    this.getdata();
    this.ContaForm = new FormGroup({
      ContaId: new FormControl(0),
      CodBanco: new FormControl("", [Validators.required]),
      NumeroConta: new FormControl("", [Validators.required]),
      NumeroAgencia: new FormControl("", [Validators.required]),
      Cpf: new FormControl("", [Validators.required]),
      NomeTitular: new FormControl("", [Validators.required]),
      dataAbertura: new FormControl(new Date()),
    })
  }

  getdata() {
    this.CadastroContaService.getData().subscribe((data: any[]) => {
      this.data = data;
    })
  }

  deleteData(id) {
    this.CadastroContaService.deleteData(id).subscribe((data: any[]) => {
      this.data = data;
      this.getdata();
    })
  }

  Salvar() {
    this.submitted = true;
    if (this.ContaForm.invalid) {
      return;
    }
    this.CadastroContaService.postData(this.ContaForm.value).subscribe((data: any[]) => {
      this.data = data;
      this.resetForm();
    })
  }
  Atualizar() {
    this.submitted = true;
    if (this.ContaForm.invalid) {
      return;
    }
    this.CadastroContaService.putData(this.ContaForm.value.ContaId,
      this.ContaForm.value).subscribe((data: any[]) => {
        this.data = data;
        this.resetForm();
      })
  }

  EditData(Data) {
    this.ContaForm.controls["ContaId"].setValue(Data.contaId);
    this.ContaForm.controls["CodBanco"].setValue(Data.codBanco);
    this.ContaForm.controls["NumeroConta"].setValue(Data.numeroConta);
    this.ContaForm.controls["NumeroAgencia"].setValue(Data.numeroAgencia);
    this.ContaForm.controls["Cpf"].setValue(Data.cpf);
    this.ContaForm.controls["NomeTitular"].setValue(Data.nomeTitular);
    this.ContaForm.controls["dataAbertura"].setValue(Data.dataAbertura);
    this.EventValue = "Atualizar";

  }
  resetForm() {
    this.getdata();
    this.ContaForm.reset();
    this.EventValue = "Salvar";
    this.submitted = false;
  } 
}
