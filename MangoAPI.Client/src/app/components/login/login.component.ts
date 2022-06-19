import { Component } from '@angular/core';
import {LoginCommand} from "../../types/requests/LoginCommand";
import {SessionService} from "../../services/session.service";
import {Router} from "@angular/router";
import {ValidationService} from "../../services/validation.service";
import {ErrorNotificationService} from "../../services/error-notification.service";
import {TokensService} from "../../services/tokens.service";

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.scss']
})
export class LoginComponent {
  constructor(private _sessionService: SessionService,
              private _tokensService: TokensService,
              private _router: Router,
              private _validationService: ValidationService,
              private _errorNotificationService: ErrorNotificationService) {}

  public loginCommand: LoginCommand = {
    email: '',
    password: ''
  }

  onLoginClick(): void {
    let emailFieldValidationResult = this._validationService.validateField(this.loginCommand.email, 'Email');
    let passwordFieldValidationResult = this._validationService.validateField(this.loginCommand.password, 'Password');

    if(!emailFieldValidationResult || !passwordFieldValidationResult) {
      return;
    }

    this._tokensService.clearTokens();

    this._sessionService.createSession(this.loginCommand).subscribe(response => {
      this._tokensService.setTokens(response.tokens);
      this._router.navigateByUrl("app?methodName=chats").then(r => r);
    }, error => {
      this._errorNotificationService.notifyOnError(error);
    });
  }
}
