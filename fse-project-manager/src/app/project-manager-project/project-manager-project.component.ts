import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from "@angular/forms";
import { Router } from "@angular/router";  
import { ProjectService } from 'src/app/Project/project.service';
import { DatePipe } from '@angular/common';

@Component({
  selector: 'app-pops-purchaseorder',
  templateUrl: './pops-purchaseorder.component.html',
  styleUrls: ['./pops-purchaseorder.component.css'],
  providers:[DatePipe]
})
export class ProjectManagerProjectComponent implements OnInit {

  purchaseOrderformlabel: string = 'Add Item';  
  constructor(private formBuilder: FormBuilder, private router: Router, private purchaseOrderService: PurchaseOrderService, private datePipe: DatePipe) {  
  }  
  
  addForm: FormGroup;
  btnvisibility: boolean = true;  
  ngOnInit() {  
  
    this.addForm = this.formBuilder.group({      
      purchaseOrderNo: ['', [Validators.required, Validators.maxLength(4)]],
      purchaseDate: [],  
      supplierNo: ['', [Validators.required, Validators.maxLength(4)]], 
      itemCode: ['', [Validators.required, Validators.maxLength(4)]],
      quantity: []  
    });  
  
    let purchaseOrder = localStorage.getItem('editPurchaseOrder');  
    if (purchaseOrder != undefined && purchaseOrder != '') {
      let purchaseOrderValue : string[] = purchaseOrder.split('|');
      this.purchaseOrderService.searchPurchaseOrder(purchaseOrderValue[0], purchaseOrderValue[1]).subscribe(data => {  
        this.addForm.patchValue(data); 
        if(data.quantity === undefined || data.quantity === null || data.quantity == 0)
        {
          this.addForm.controls['quantity'].setValue("");
        }
        if(data.purchaseDate != undefined && data.purchaseDate != null)
        {
          this.addForm.controls['purchaseDate'].setValue(this.datePipe.transform(data.purchaseDate, 'yyyy-MM-dd'));
        }        
      })  
      this.btnvisibility = false;
      this.purchaseOrderformlabel = 'Edit Purchase Order';      
    } 
  }  
  onSubmit() {
    this.purchaseOrderService.createPurchaseOrder(this.addForm.value)  
      .subscribe((data: any) => {
        if(data)
        {  
          alert("Purchase Order added successfully");        
          this.router.navigate(['purchase-order-list']); 
        }
        else
        {
          alert("Purchase Order add failed due to server error, kindly check whether Supplier No and Item Code exists and try again");     
        }
      },  
      error => {  
        alert(error);  
      });  
  }  
  onUpdate() {      
    this.purchaseOrderService.updatePurchaseOrder(this.addForm.value).subscribe((data: any) => {
      if(data)
      {  
        alert("Purchase Order updated successfully");        
        localStorage.removeItem('editPurchaseOrder') 
        this.router.navigate(['purchase-order-list']);  
      }
      else
      {
        alert("Purchase Order update failed due to server error, kindly try again");     
      }
    },  
    error => {  
      alert(error);  
    });
  }
}
