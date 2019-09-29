import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from "@angular/forms";
import { Router } from "@angular/router";  
import { TaskService } from './../Task/task.service';
import { Select2OptionData } from 'ng-select2';
import { ProjectService } from 'src/app/Project/project.service';
import { UserService } from 'src/app/User/user.service';

@Component({
  selector: 'app-project-manager-task',
  templateUrl: './project-manager-task.component.html',
  styleUrls: ['./project-manager-task.component.css']
})
export class ProjectManagerTaskComponent implements OnInit {

  searchProjects: Array<Select2OptionData>; 
  searchUsers: Array<Select2OptionData>;
  searchParentTasks: Array<Select2OptionData>;

  taskformlabel: string = 'Add Task';  
  constructor(private formBuilder: FormBuilder, private router: Router, private taskService: TaskService, private projectService: ProjectService, private userService: UserService) {  
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

    this.getParentTaskDynamicList();
    this.getUserDynamicList();
    this.getProjectDynamicList();
  }
  
  getProjectDynamicList(){
    this.projectService.getProjectList()  
    .subscribe((data: Array<Select2OptionData>) => {
      this.searchProjects = data;      
      if(data.length == 0)  
      {
        alert("No project List found");         
      }         
    }); 
}

getUserDynamicList(){
  this.userService.getUserList()  
  .subscribe((data: Array<Select2OptionData>) => {
    this.searchUsers = data;      
    if(data.length == 0)  
    {
      alert("No user List found");         
    }         
  }); 
}

getParentTaskDynamicList(){
  this.taskService.getParentTaskList()  
  .subscribe((data: Array<Select2OptionData>) => {
    this.searchParentTasks = data;      
    if(data.length == 0)  
    {
      alert("No parent task List found");         
    }         
  }); 
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