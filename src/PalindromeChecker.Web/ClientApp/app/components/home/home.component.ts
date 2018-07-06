import { Component } from '@angular/core';
import { Palindrome } from '../../palindrome';
import { PalindromeService } from '../app/app.service';

@Component({
    selector: 'home',
    templateUrl: './home.component.html'
})
export class HomeComponent {

    palindrome: Palindrome = {
        id: 0,
        name: '',
        dateAdded: ''
    };

    constructor(
        private palindromeService: PalindromeService
    ) {
    }

    check(): void {

        var cleanedString = this.removeNonAlphaNumerics(this.palindrome.name);
        cleanedString = this.reverseString(cleanedString);

        if (cleanedString !== this.palindrome.name) {
            alert('fail');
            return;
        }

        //this.palindromeService.createPalindrome(this.palindrome)
        //    .catch(this.handleError);
    }

    private handleError(error: Response) {
        console.log('Error', error);
    }

    private removeNonAlphaNumerics(input: string) {
        var rgx = /[^a-zA-Z0-9]/g;
        input = input.replace(rgx, '').toLocaleLowerCase();
        return input;
    }

    private reverseString(input: string) {
        return input.split("").reverse().join("");
    }
}
