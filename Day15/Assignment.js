var ContactManager = /** @class */ (function () {
    function ContactManager() {
        this.contacts = [];
    }
    ContactManager.prototype.addContact = function (contact) {
        var existing = this.contacts.find(function (c) { return c.id === contact.id; });
        if (existing) {
            console.log("Error: Contact with ID ".concat(contact.id, " already exists."));
            return;
        }
        this.contacts.push(contact);
        console.log("Success: Contact '".concat(contact.name, "' added."));
    };
    // View all contacts
    ContactManager.prototype.viewContacts = function () {
        return this.contacts;
    };
    ContactManager.prototype.modifyContact = function (id, updatedContact) {
        var contact = this.contacts.find(function (contact) { return contact.id === id; });
        if (!contact) {
            console.log("Error: Contact with ID ".concat(id, " not found."));
            return;
        }
        Object.assign(contact, updatedContact);
        console.log("Contact with ID ".concat(id, " updated."));
    };
    ContactManager.prototype.deleteContact = function (id) {
        var contact = this.contacts.find(function (contact) { return contact.id === id; });
        if (!contact) {
            console.log("Error: Contact with ID ".concat(id, " not found."));
            return;
        }
        this.contacts = this.contacts.filter(function (contact) { return contact.id !== id; });
        console.log("Success: Contact with ID ".concat(id, " deleted."));
    };
    return ContactManager;
}());
var manager = new ContactManager();
console.log("Adding Contacts...");
manager.addContact({ id: 1, name: "Nitin", email: "nitin@example.com", phone: "1234567890" });
manager.addContact({ id: 2, name: "Rakesh", email: "rakesh@example.com", phone: "1234567890" });
// Test: Viewing Contacts
console.log(manager.viewContacts());
// Test: Modifying a Contact
manager.modifyContact(1, { phone: "1112223333", email: "singhnitin@example.com" });
// Test: Viewing Contacts after Modification
console.log(manager.viewContacts());
// Test: Deleting a Contact
manager.deleteContact(2);
// Test: Viewing Contacts after Deletion
console.log(manager.viewContacts());
// Test: Attempting to Modify a Non-Existent Contact
manager.modifyContact(3, { name: "Charlie" });
// Test: Attempting to Delete a Non-Existent Contact
manager.deleteContact(3);
