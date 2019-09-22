import { Component, OnInit } from '@angular/core';
import { PurchaseOrderService } from 'src/app/Project/project.service';
import { Router } from "@angular/router"; 
import { PurchaseOrder } from '../../../Project/project';

@Component({
  selector: 'app-purchase-order-list',
  templateUrl: './purchase-order-list.component.html',
  styleUrls: ['./purchase-order-list.component.css']
})
export class PurchaseOrderListComponent implements OnInit {

  purchaseOrders: any;  
  
  constructor(private purchaseOrderService: PurchaseOrderService, private router: Router, ) { }  
  
  ngOnInit() { 
      localStorage.removeItem('editPurchaseOrder')    
      this.getPurchaseOrders();    
  } 

  getPurchaseOrders()
  {
      this.purchaseOrderService.getPurchaseOrders()  
      .subscribe((data: PurchaseOrder[]) => {
        this.purchaseOrders = data;  
        if(data.length == 0)  
        {
          alert("No purchase orders found");          
        }         
      });
  }

  deletePurchaseOrder(purchaseOrder: PurchaseOrder): void {  
    this.purchaseOrderService.deletePurchaseOrder(purchaseOrder.purchaseOrderNo, purchaseOrder.itemCode)  
    .subscribe((data: any) => {
      if(data)
      {  
        alert("Purchase Order deleted successfully");        
        this.getPurchaseOrders();  
      }
      else
      {
        alert("Purchase Order deletion failed due to server error, kindly try again");     
      }
    },  
    error => {  
      alert(error);  
    });  
  }  
  
  editPurchaseOrder(purchaseOrder: PurchaseOrder): void {  
    localStorage.removeItem('editPurchaseOrder');  
    localStorage.setItem('editPurchaseOrder', purchaseOrder.purchaseOrderNo + "|" + purchaseOrder.itemCode);  
    this.router.navigate(['popspurchaseorder']);  
  }
}
