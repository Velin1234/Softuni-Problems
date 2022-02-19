class ArtGallery {
    constructor(creator) {
        this.creator = creator;
        this.possibleArticles = {
            "picture": 200,
            "photo": 50,
            "item": 250
        }
        this.listOfArticles = [];
        this.guests = [];
    }

    addArticle(articleModel, articleName, quantity) {
        articleModel = articleModel.toLowerCase();
        quantity = Number(quantity);
        if (!this.possibleArticles[articleModel]) {
            throw new Error("This article model is not included in this gallery!");
        }
        let article = {
            'name': articleName,
            'model': articleModel.toLowerCase(),
            'quantity': quantity
        }


        if (this.listOfArticles.some(a => a.name === articleName && a.model === articleModel)) {
            article = this.listOfArticles.find(a => a.name === articleName && a.model === articleModel);
            article.quantity += quantity;
        } else {

            this.listOfArticles.push(article);
        }
        return `Successfully added article ${articleName} with a new quantity- ${article.quantity}.`
    }

    inviteGuest(guestName, personality) {
        if (this.guests.some(g => g.name === guestName)) {
            //Make to Error
            throw new Error(`${guestName} has already been invited.`);
        }
        let points = 50;
        switch (personality) {
            case "Vip":
                points = 500;
                break;
            case "Middle":
                points = 250;
                break;
        }

        let guest = {
            'name': guestName,
            'points': points,
            'purchaseArticle': 0
        }

        this.guests.push(guest);
        return `You have successfully invited ${guestName}!`;
    }

    buyArticle(articleModel, articleName, guestName) {
        if (!this.listOfArticles.some(a => a.name === articleName)) {
            throw new Error("This article is not found.");
        }
        if (this.listOfArticles.some(a => a.name === articleName && a.model != articleModel)) {
            throw new Error("This article is not found.");
        }

        let article = this.listOfArticles.find(a => a.name === articleName && a.model === articleModel);

        if (article.quantity === 0) {
            return `The ${articleName} is not available.`;
        }

        if (!this.guests.some(g => g.name === guestName)) {
            return `This guest is not invited.`;
        }

        let guest = this.guests.find(g => g.name === guestName);

        if (guest.points < this.possibleArticles[article.model]) {
            return "You need to more points to purchase the article.";
        }

        guest.points -= this.possibleArticles[article.model];
        guest.purchaseArticle++;
        article.quantity -= 1;

        return `${guestName} successfully purchased the article worth ${this.possibleArticles[article.model]} points.`
    }

    showGalleryInfo(criteria) {
        let resutlt = [];
        switch (criteria) {
            case "article":
                resutlt.push("Articles information:");
                this.listOfArticles.forEach(article => {
                    resutlt.push(`${article.model} - ${article.name} - ${article.quantity}`);
                });
                break;
            case "guest":
                resutlt.push("Guests information:");
                this.guests.forEach(guest => {
                    resutlt.push(`${guest.name} - ${guest.purchaseArticle}`);
                });
                break;
        }
        return resutlt.join('\n');
    }
}

const artGallery = new ArtGallery('Curtis Mayfield');

// console.log(artGallery.addArticle('picture', 'Mona Liza', 3));
// console.log(artGallery.addArticle('Item', 'Ancient vase', 2));
// console.log(artGallery.addArticle('PICTURE', 'Mona Liza', 1));

// console.log(artGallery.inviteGuest('John', 'Vip'));
// console.log(artGallery.inviteGuest('Peter', 'Middle'));
// console.log(artGallery.inviteGuest('John', 'Middle'));

// artGallery.addArticle('picture', 'Mona Liza', 3);
// artGallery.addArticle('Item', 'Ancient vase', 2);
// artGallery.addArticle('picture', 'Mona Liza', 1);
// artGallery.inviteGuest('John', 'Vip');
// artGallery.inviteGuest('Peter', 'Middle');
// console.log(artGallery.buyArticle('picture', 'Mona Liza', 'John'));
// console.log(artGallery.buyArticle('item', 'Ancient vase', 'Peter'));
// console.log(artGallery.buyArticle('item', 'Mona Liza', 'John'));

// artGallery.addArticle('picture', 'Mona Liza', 3);
// artGallery.addArticle('Item', 'Ancient vase', 2);
// artGallery.addArticle('picture', 'Mona Liza', 1);
// artGallery.inviteGuest('John', 'Vip');
// artGallery.inviteGuest('Peter', 'Middle');
// artGallery.buyArticle('picture', 'Mona Liza', 'John');
// artGallery.buyArticle('item', 'Ancient vase', 'Peter');
// console.log(artGallery.showGalleryInfo('article'));
// console.log(artGallery.showGalleryInfo('guest'));