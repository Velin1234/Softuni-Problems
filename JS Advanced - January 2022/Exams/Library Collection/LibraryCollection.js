class LibraryCollection {
    constructor(capacity) {
        this.capacity = capacity;
        this.books = [];
    }

    addBook(bookName, bookAuthor) {
        let book = {
            'name': bookName,
            'author': bookAuthor,
            'payed': false
        }
        this.books.push(book);
        if (this.books.length > this.capacity) {
            this.books.pop();
            throw new Error("Not enough space in the collection.");
        }
        return `The ${bookName}, with an author ${bookAuthor}, collect.`;
    }

    payBook(bookName) {
        if (!this.books.some(b => b.name === bookName)) {
            throw new Error(`${bookName} is not in the collection.`);
        }

        let book = this.books.find(b => b.name === bookName);
        if (book.payed) {
            throw new Error(`${bookName} has already been paid.`);
        }
        book.payed = true;
        return `${bookName} has been successfully paid.`;
    }

    removeBook(bookName) {
        if (!this.books.some(b => b.name === bookName)) {
            throw new Error(`The book, you're looking for, is not found.`);
        }

        let book = this.books.find(b => b.name === bookName);

        if (!book.payed) {
            throw new Error(`${bookName} need to be paid before removing from the collection.`);
        }

        this.books.splice(this.books.indexOf(book), 1);
        return `${bookName} remove from the collection.`;
    }

    getStatistics(...param) {
        let result = [];
        if (param.length === 0) {
            result.push(`The book collection has ${this.capacity - this.books.length} empty spots left.`);
            this.books.sort((a, b) => a.name - b.name);
            this.books.forEach(book => {
                let payedFlag = 'Not Paid';
                if (book.payed) {
                    payedFlag = 'Has Paid';
                }
                let bookInfo = `${book.name} == ${book.author} - ${payedFlag}.`
                result.push(bookInfo);
            });
            return result.join('\n');
        }
        
        let bookAuthor = param[0];
        if (!this.books.some(b => b.author === bookAuthor)) {
            throw new Error(`${bookAuthor} is not in the collection.`)
        }

        this.books.forEach(book => {
            if(book.author === bookAuthor){
                let payedFlag = 'Not Paid';
                if (book.payed) {
                    payedFlag = 'Has Paid';
                }
                let bookInfo = `${book.name} == ${book.author} - ${payedFlag}.`
                result.push(bookInfo);
            }
        });
        return result.join('\n');
    }
}

const library = new LibraryCollection(5)
// console.log(library.addBook('In Search of Lost Time', 'Marcel Proust'));
// console.log(library.addBook('Don Quixote', 'Miguel de Cervantes'));
// console.log(library.addBook('Ulysses', 'James Joyce'));

// library.addBook('In Search of Lost Time', 'Marcel Proust');
// console.log(library.payBook('In Search of Lost Time'));
// console.log(library.payBook('Don Quixote'));

// library.addBook('In Search of Lost Time', 'Marcel Proust');
// library.addBook('Don Quixote', 'Miguel de Cervantes');
// library.payBook('Don Quixote');
// console.log(library.removeBook('Don Quixote'));
// console.log(library.removeBook('In Search of Lost Time'));

// console.log(library.addBook('Don Quixote', 'Miguel de Cervantes'));
// console.log(library.getStatistics('Miguel de Cervantes'));

library.addBook('Don Quixote', 'Miguel de Cervantes');
// library.payBook('Don Quixote');
// library.addBook('In Search of Lost Time', 'Marcel Proust');
// library.addBook('Ulysses', 'James Joyce');
console.log(library.getStatistics("Miguel de Cervantes"));