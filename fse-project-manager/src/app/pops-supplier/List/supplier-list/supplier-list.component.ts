import { Component, OnInit } from '@angular/core';
import { SupplierService } from './node_modules/src/app/User/user.service';
import { Router } from "@angular/router"; 
import { Supplier } from '../../../User/user';

@Component({
  selector: 'app-supplier-list',
  templateUrl: './supplier-list.component.html',
  styleUrls: ['./supplier-list.component.css']
})
export class UserListComponent implements OnInit {

  suppliers: Supplier[];  
  
  constructor(private supplierService: SupplierService, private router: Router, ) { }  
  
  ngOnInit() {  
      localStorage.removeItem('editSupplierNo');    
      this.getSuppliers();     
  } 
  
  getSuppliers()
  {
    this.supplierService.getSuppliers()  
    .subscribe((data: Supplier[]) => {
      this.suppliers = data; 
      if(data.length == 0)  
      {
        alert("No suppliers found");         
      }      
    });
  }
  
  deleteSupplier(supplier: Supplier): void {  
    this.supplierService.deleteSupplier(supplier.supplierNo)  
    .subscribe((data: any) => {
      if(data)
      {  
        alert("Supplier deleted successfully");        
        this.getSuppliers();  
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
  
  editSupplier(supplier: Supplier): void {  
    localStorage.removeItem('editSupplierNo');  
    localStorage.setItem('editSupplierNo', supplier.supplierNo);  
    this.router.navigate(['popssupplier']);  
  }
}
