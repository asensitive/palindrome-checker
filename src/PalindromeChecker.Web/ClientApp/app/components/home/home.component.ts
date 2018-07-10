import { Component } from '@angular/core';
import { Palindrome } from '../../palindrome';
import { PalindromeService } from '../app/app.service';

@Component({
    selector: 'home',
    templateUrl: './home.component.html'
})
export class HomeComponent {

    isPalindrome: boolean;
    message: string;

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
        var reversedString = this.reverseString(cleanedString);

        this.isPalindrome = (cleanedString === reversedString);

        if (this.isPalindrome) {
            this.message = "The string entered is a palindrome.";
            this.save();
        } else {
            this.message = "The string entered is not a palindrome.";
        }
    }

    save(): any {
        this.palindromeService.createPalindrome(this.palindrome).catch(this.handleError);
    }

    reset(): void {
        this.message = '';
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
