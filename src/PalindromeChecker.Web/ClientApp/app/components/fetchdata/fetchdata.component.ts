import { Component, Inject } from '@angular/core';
import { Http } from '@angular/http';
import { Palindrome } from '../../palindrome';
import { PalindromeService } from '../app/app.service';

@Component({
    selector: 'fetchdata',
    templateUrl: './fetchdata.component.html'
})
export class FetchDataComponent {
    public palindromes: Palindrome[];

    constructor(private palindromeService: PalindromeService) {
        this.palindromeService.getPalindromes().then(result => {
            this.palindromes = result as Palindrome[];
        }, error => console.error(error));
    }
}

