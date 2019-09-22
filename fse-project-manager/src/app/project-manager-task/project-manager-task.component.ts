import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from "@angular/forms";
import { Router } from "@angular/router";  
import { TaskService } from './../Task/task.service';

@Component({
  selector: 'app-project-manager-task',
  templateUrl: './project-manager-task.component.html',
  styleUrls: ['./project-manager-task.component.css']
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
  
    let taskID = localStorage.getItem('editTaskID');  
    if (taskID != undefined && taskID != '') {  
      this.taskService.searchTask(taskID).subscribe(data => {  
        this.addForm.patchValue(data);
      })  
      this.btnvisibility = false;
      this.taskformlabel = 'Edit Task';      
    }
  }  
  onSubmit() {
    this.taskService.createTask(this.addForm.value)  
      .subscribe((data: any) => {
        if(data)
        {  
          alert("Task added successfully");        
          this.router.navigate(['task-list']); 
        }
        else
        {
          alert("Task add failed due to server error, kindly check for duplicate record and try again");     
        }
      },  
      error => {  
        alert(error);  
      });  
  }  
  onUpdate() {      
    this.taskService.updateTask(this.addForm.value).subscribe((data: any) => {
      if(data)
      {  
        alert("Task updated successfully");        
        localStorage.removeItem('editTaskID') 
        this.router.navigate(['task-list']);  
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