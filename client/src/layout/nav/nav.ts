import { Component, inject, signal } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { AccountService } from '../../services/account-service';
import { Router, RouterLink, RouterLinkActive } from '@angular/router';
import { ToastService } from '../../services/toast-service';


@Component({
  selector: 'app-nav',
  imports: [FormsModule, RouterLink, RouterLinkActive],
  templateUrl: './nav.html',
  styleUrl: './nav.css'
})
export class Nav {
  protected accountService = inject(AccountService)
  private router = inject(Router);
  private toast = inject(ToastService);
  protected creds: any = {}
  protected loggedIn = signal(false)
  login() 
  {
    this.accountService.login(this.creds).subscribe({
      next: result => {
        this.router.navigateByUrl('/members'),
        this.toast.success("logged in succesfully")
        this.loggedIn.set(true),
        this.creds = {}
      },
      error: error => {
        this.toast.error(error.error);
      }

    })
  }
  
  loggedOut()
  {
    this.accountService.logout();
    this.router.navigateByUrl('/');
  }

}
