import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from "@angular/forms";
import { Router } from "@angular/router";  
import { TaskService } from './../Task/task.service';

@Component({
  selector: 'app-pops-item',
  templateUrl: './pops-item.component.html',
  styleUrls: ['./pops-item.component.css']
})
export class ProjectManagerTaskComponent implements OnInit {

  taskformlabel: string = 'Add Task';  
  constructor(private formBuilder: FormBuilder, private router: Router, private taskService: TaskService) {  
  }  
  
  addForm: FormGroup;  
  btnvisibility: boolean = true;  
  ngOnInit() {  
  
    this.addForm = this.formBuilder.group({  
      itemCode: ['', [Validators.required, Validators.maxLength(4)]],
      itemDesc: ['', Validators.required],
      itemRate: []             
    });  
  
    let itemcode = localStorage.getItem('editItemCode');  
    if (itemcode != undefined && itemcode != '') {  
      this.taskService.searchItem(itemcode).subscribe(data => {  
        this.addForm.patchValue(data); 
        if(data.itemRate == 0)
        {
          this.addForm.controls['itemRate'].setValue("");
        }
      })  
      this.btnvisibility = false;
      this.itemformlabel = 'Edit Item';      
    }
  }  
  onSubmit() {
    this.taskService.createItem(this.addForm.value)  
      .subscribe((data: any) => {
        if(data)
        {  
          alert("Item added successfully");        
          this.router.navigate(['item-list']); 
        }
        else
        {
          alert("Item add failed due to server error, kindly check for duplicate record and try again");     
        }
      },  
      error => {  
        alert(error);  
      });  
  }  
  onUpdate() {      
    this.taskService.updateItem(this.addForm.value).subscribe((data: any) => {
      if(data)
      {  
        alert("Item updated successfully");        
        localStorage.removeItem('editItemCode') 
        this.router.navigate(['item-list']);  
      }
      else
      {
        alert("Item update failed due to server error, kindly try again");     
      }
    },  
    error => {  
      alert(error);  
    });
  }
}