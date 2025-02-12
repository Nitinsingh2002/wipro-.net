interface Contact {
    id: number,
    name: string,
    email: string,
    phone: string
}

class ContactManager {
    private contacts: Contact[] = [];

    addContact(contact: Contact): void {
        const existing = this.contacts.find(c => c.id === contact.id);
        if (existing) {
            console.log(`Error: Contact with ID ${contact.id} already exists.`);
            return;
        }
        this.contacts.push(contact);
        console.log(`Success: Contact '${contact.name}' added.`);
    }


    // View all contacts
    viewContacts(): Contact[] {
        return this.contacts;
    }


    modifyContact(id: number, updatedContact: Partial<Contact>): void {
        const contact = this.contacts.find(contact => contact.id === id);
        if (!contact) {
            console.log(`Error: Contact with ID ${id} not found.`);
            return;
        }
        Object.assign(contact, updatedContact);
        console.log(`Contact with ID ${id} updated.`);
    }
    


    deleteContact(id: number): void {
        const contact = this.contacts.find(contact => contact.id === id);
        if (!contact) {
            console.log(`Error: Contact with ID ${id} not found.`);
            return;
        }
        this.contacts = this.contacts.filter(contact => contact.id !== id);
        console.log(`Success: Contact with ID ${id} deleted.`);
    }

}




const manager = new ContactManager();

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
