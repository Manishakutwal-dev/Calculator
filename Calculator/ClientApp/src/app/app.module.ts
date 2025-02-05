import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { LoginComponent } from './login/login.component';
import { EvaluateComponent } from './evaluate/evaluate.component';
import { HistoryComponent } from './history/history.component';
import { ReactiveFormsModule } from '@angular/forms';

@NgModule({
    declarations: [
        AppComponent,
        NavMenuComponent,
        LoginComponent,
        EvaluateComponent,
        HistoryComponent,
    ],
    imports: [
        BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
        HttpClientModule,
        FormsModule,
        ReactiveFormsModule,
        RouterModule.forRoot([
            { path: '', component: EvaluateComponent,  },
            { path: 'evaluate', component: EvaluateComponent,  },
  { path: 'login', component: LoginComponent },
  { path: 'history', component: HistoryComponent },
  { path: '', component: EvaluateComponent, },
        ])
    ],
    providers: [],
    bootstrap: [AppComponent]
})
export class AppModule { }
