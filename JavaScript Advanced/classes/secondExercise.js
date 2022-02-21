class LibraryCollection{
    constructor(capacity){
        this.capacity = capacity;
        this.books = [];
    }

    addBook(bookName, bookAuthor){
      let book = {
          'bookName': bookName,
          'payed': false,
          'bookAuthor': bookAuthor
      };

      if (this.books.length >= this.capacity){
          throw new Error('Not enough space in the collection.');
      } else {
         this.books.push(book);
        return `The ${bookName}, with an author ${bookAuthor}, collect.`
      }
    }

    payBook(bookName){
        if (!this.books.some(x => x.bookName == bookName)){
            throw new Error(`${bookName} is not in the collection.`);
        }

        let neededBook = this.books.find(x => x.bookName == bookName);
        if (neededBook.payed=== true){
            throw new Error(`${bookName} has alredy been paid.`);
        }
        
        else {
            neededBook.payed = true;
            return `${bookName} has been successfully paid.`;
        }

    }
    
    removeBook(bookName){
        if (!this.books.some(x => x.bookName == bookName)){
            throw new Error("The book, you're looking for, is not found.");
        }
        let wantedBook = this.books.find(x => x.bookName == bookName);
        if (wantedBook.payed == false){
            throw new Error(`${bookName} need to be paid before removing from the collection.`);
        }
        
        else { 
            let remove = this.books.findIndex(x => x.bookName == bookName);
            this.books.splice(remove, 1);
            return `${bookName} remove from the collection.`;
        }
    }

    getStatistics(bookAuthor){
        if (bookAuthor == null){
            let result = [];
           for (const el of this.books) {
               if (el.payed === true){
                   el.payed = 'Has Paid';
               } else {
                   el.payed = 'Not Paid'
               }
           }

            result.push(`The book collection has ${this.capacity -= this.books.length} empty spots left.`);
            this.books.sort((a, b) => a.bookAuthor.localeCompare(b.bookName)).
            forEach(x => {
                result.push(`${x.bookName} == ${x.bookAuthor} - ${x.payed}.`);
            });

            return result.join('\n');
          
        } else {
            let wanted = this.books.find(x => x.bookAuthor == bookAuthor);

            if (wanted == undefined){
                throw new Error(`${bookAuthor} is not in the collection.`)
            } else {
                let result = [];

                for (const el of this.books) {
                    if (el.payed === true){
                        el.payed = 'Has Paid';
                    } else {
                        el.payed = 'Not Paid'
                    }
                }

               for (const el of this.books){
                   if (el.bookAuthor == bookAuthor){
                       result.push(`${el.bookName} == ${el.bookAuthor} - ${el.payed}.`);
                   }
               }

               return result.join();
            }
        }
      
    }
}class LibraryCollection{
    constructor(capacity){
        this.capacity = capacity;
        this.books = [];
    }

    addBook(bookName, bookAuthor){
      let book = {
          'bookName': bookName,
          'payed': false,
          'bookAuthor': bookAuthor
      };

      if (this.books.length >= this.capacity){
          throw new Error('Not enough space in the collection.');
      } else {
         this.books.push(book);
        return `The ${bookName}, with an author ${bookAuthor}, collect.`
      }
    }

    payBook(bookName){
        if (!this.books.some(x => x.bookName == bookName)){
            throw new Error(`${bookName} is not in the collection.`);
        }

        let neededBook = this.books.find(x => x.bookName == bookName);
        if (neededBook.payed=== true){
            throw new Error(`${bookName} has alredy been paid.`);
        }
        
        else {
            neededBook.payed = true;
            return `${bookName} has been successfully paid.`;
        }

    }
    
    removeBook(bookName){
        if (!this.books.some(x => x.bookName == bookName)){
            throw new Error("The book, you're looking for, is not found.");
        }
        let wantedBook = this.books.find(x => x.bookName == bookName);
        if (wantedBook.payed == false){
            throw new Error(`${bookName} need to be paid before removing from the collection.`);
        }
        
        else { 
            let remove = this.books.findIndex(x => x.bookName == bookName);
            this.books.splice(remove, 1);
            return `${bookName} remove from the collection.`;
        }
    }

    getStatistics(bookAuthor){
        if (bookAuthor == null){
            let result = [];
           for (const el of this.books) {
               if (el.payed === true){
                   el.payed = 'Has Paid';
               } else {
                   el.payed = 'Not Paid'
               }
           }

            result.push(`The book collection has ${this.capacity -= this.books.length} empty spots left.`);
            this.books.sort((a, b) => a.bookAuthor.localeCompare(b.bookName)).
            forEach(x => {
                result.push(`${x.bookName} == ${x.bookAuthor} - ${x.payed}.`);
            });

            return result.join('\n');
          
        } else {
            let wanted = this.books.find(x => x.bookAuthor == bookAuthor);

            if (wanted == undefined){
                throw new Error(`${bookAuthor} is not in the collection.`)
            } else {
                let result = [];

                for (const el of this.books) {
                    if (el.payed === true){
                        el.payed = 'Has Paid';
                    } else {
                        el.payed = 'Not Paid'
                    }
                }

               for (const el of this.books){
                   if (el.bookAuthor == bookAuthor){
                       result.push(`${el.bookName} == ${el.bookAuthor} - ${el.payed}.`);
                   }
               }

               return result.join();
            }
        }
      
    }
}