import { Injectable } from '@angular/core';
import { Headers, Http } from '@angular/http';
import 'rxjs/add/operator/toPromise';

import { Palindrome } from '../../palindrome';

@Injectable()
export class PalindromeService {

    private headers = new Headers({ 'Content-Type': 'application/json' });

    private palindromesUrl = 'api/palindromes';

    constructor(private http: Http) { }

    getPalindromes(): Promise<Palindrome[]> {
        return this.http.get(this.palindromesUrl)
            .toPromise()
            .then(response => response.json() as Palindrome[])
            .catch(this.handleError);
    }

    createPalindrome(palindrome: Palindrome): Promise<Palindrome> {
        return this.http
            .post(this.palindromesUrl, JSON.stringify(palindrome), { headers: this.headers })
            .toPromise()
            .then(res => res.json() as Palindrome)
            .catch(this.handleError);
    }

    private handleError(error: any): Promise<any> {
        console.error('An error occurred', error);
        return Promise.reject(error.message || error);
    }
}