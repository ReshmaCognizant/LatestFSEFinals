import { Component, OnInit } from '@angular/core';
import { UserService } from './node_modules/src/app/User/user.service';
import { Router } from "@angular/router"; 
import { User } from '../../../User/user';

@Component({
  selector: 'app-supplier-list',
  templateUrl: './supplier-list.component.html',
  styleUrls: ['./supplier-list.component.css']
})
export class UserListComponent implements OnInit {

  users: User[];  
  
  constructor(private userService: UserService, private router: Router, ) { }  
  
  ngOnInit() {  
      localStorage.removeItem('editUser');    
      this.getUsers();     
  } 
  
  getUsers()
  {
    this.userService.getUsers()  
    .subscribe((data: User[]) => {
      this.users = data; 
      if(data.length == 0)  
      {
        alert("No suppliers found");         
      }      
    });
  }
  
  deleteUser(user: User): void {  
    this.userService.deleteUser(user.userID)  
    .subscribe((data: any) => {
      if(data)
      {  
        alert("Supplier deleted successfully");        
        this.getUsers();  
      }
      else
      {
        alert("Supplier deletion failed due to server error, kindly try again");     
      }
    },  
    error => {  
      alert(error);  
    });   
  }
  
  editSupplier(user: User): void {  
    localStorage.removeItem('editUserID');  
    localStorage.setItem('editUserID', user.userID);  
    this.router.navigate(['projectmanageruser']);  
  }
}
