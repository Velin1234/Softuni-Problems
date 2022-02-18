let { expect } = require('chai');
let { Repository } = require("./solution.js");

describe("Repository", () => {
    let properties = {
        name: "string",
        age: "number",
        birthday: "object"
    };

    let entity = {
        name: "Pesho",
        age: 22,
        birthday: new Date(1998, 0, 7)
    };

    describe("Initialization", () => {
        it("Should add props property on init", function () {
            let repo = new Repository(properties);
            expect(repo).to.have.property('props');
            expect(repo.props).to.deep.equal(properties);
        });

        it("Should have property data on init", () => {
            let repo = new Repository(properties);
            expect(repo).to.have.property('data');
            expect(typeof repo.data).is.equal('object');
            expect(repo.data).instanceOf(Map);
        })

    });

    describe("Add entity", () => {
        it("Should return incremented id if valid entity is added", () => {
            let repo = new Repository(properties)
            expect(repo.add(entity)).to.equal(0);
            expect(repo.add(entity)).to.equal(1);
        });

        it("Should store valid entity in data map", () => {
            let repo = new Repository(properties)
            repo.add(entity);
            expect(repo.data.get(0)).not.to.be.undefined;
            expect(repo.data.get(0)).to.have.property('name').that.equal('Pesho');
            expect(repo.data.get(0)).to.have.property('age').that.equal(22);
            expect(repo.data.get(0)).to.have.property('birthday');
        });

        it("Should throw error if property is missing", () => {
            let entity = {
                name: "Pesho",
                age: 22,
            };
            let repo = new Repository(properties);
            expect(() => repo.add(entity)).to.throw(Error, `Property birthday is missing from the entity!`);
        });

        it("Should throw error if property has other type", () => {
            let entity = {
                name: "Pesho",
                age: 22,
                birthday: '1998-01-06T22:00:00.000Z'
            };
            let repo = new Repository(properties);

            expect(() => repo.add(entity).to.throw(Error, `Property birthday is not of correct type!`));
        });
    });

    describe("Get count", () => {
        it("Should return number of entities", () => {
            let repo = new Repository(properties);
            repo.add(entity);
            repo.add(entity);
            repo.add(entity);
            expect(repo.count).is.equal(3);
        });
        it("Should return zero if no added entities", () => {
            let repo = new Repository(properties);
            expect(repo.count).is.equal(0);
        });
    });

    describe("Get Id", () => {
        it("Should return entity by id", () => {
            let repo = new Repository(properties);
            repo.add(entity);
            expect(repo.getId(0)).to.deep.equal(entity);
        });

        it("Should throw error when no id is found", () => {
            let repo = new Repository(properties);
            expect(() => repo.getId(0).to.throw(Error, `Entity with id: 0 does not exist!`));
        })
    });

    describe("Update", () => {
        it("Should update one valid entity with another", () => {
            let newEntity = {
                name: "Gosho",
                age: 52,
                birthday: new Date(1999, 0, 7)
            };
            let repo = new Repository(properties);
            repo.add(entity);
            repo.update(0, newEntity);

            expect(repo.getId(0).name).to.equal("Gosho");
        });

        it("Should throw error if invalid update", () => {
            let repo = new Repository(properties);
            expect(() => repo.update(0, entity)).to.throw(Error, `Entity with id: 0 does not exist!`);
        });
    });

    describe("Delete", () => {
        it("Should throw throw error if invalid delete", () => {
            let repo = new Repository(properties);
            expect(() => repo.del(0)).to.throw(Error, `Entity with id: 0 does not exist!`);
        })

        it("Should delete entity", () => {
            let repo = new Repository(properties);
            repo.add(entity);
            repo.add(entity);
            repo.del(0);
            expect(repo.count).to.equal(1);
        });
    });
});
