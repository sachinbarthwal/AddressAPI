import { Component } from '@angular/core';
import { AddressService } from '../../services/address.service';

@Component({
  selector: 'app-address-form',
  templateUrl: './address-form.component.html',
  styleUrls: ['./address-form.component.css']
})
export class AddressFormComponent {
  name: string = '';
  address: string = '';
  result: any = null;
  isLoading: boolean = false; // Flag for loading state

  constructor(private addressService: AddressService) { }

  onSubmit() {
    this.isLoading = true; // Set loading to true when form is submitted

    this.addressService.submitAddress({ name: this.name, address: this.address })
      .subscribe(
        response => {
          this.result = response;
          console.log('Success:', response);
        },
        error => console.error('Error:', error),
        () => {
          this.isLoading = false; // Reset loading state after data is fetched
        }
      );
  }
}
