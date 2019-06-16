import { Component, OnInit } from '@angular/core';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';
import { AirplaneService } from '../services/airplane.service';

@Component({
  selector: 'app-airplane-add',
  templateUrl: './airplane-add.component.html',
  styleUrls: ['./airplane-add.component.css']
})
export class AirplaneAddComponent implements OnInit {


  angForm: FormGroup;
  constructor(private fb: FormBuilder, private ap: AirplaneService) {
    this.createForm();
  }

  createForm() {
    this.angForm = this.fb.group({
      codigo: ['', Validators.required],
      modelo: ['', Validators.required,Validators.maxLength(50)],
      qtd_passageiros: ['', Validators.required]
      
    });
  }

  addAirplane(codigo, modelo, qtd_passageiros) {
    this.ap.addAirplane(codigo, modelo, qtd_passageiros)
      .subscribe(res => {
        alert("Cadastrado com sucesso");
      }
      );
  }


  ngOnInit() {
  }

}
