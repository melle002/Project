# Michael Eller
## Use Cases
*****
#### Use Case 1
*****
* Name: Create Account
* Actors: Appication User, Application
* Precondition: User exists, User has application, Application installed and executing
* Trigger: User wants to create account

###### Good Flow:
* User selects "New Account"
* User provides valid data
* User selects " Create Account"
* Account created

###### Alternate Flow
* User enters invalid data
* User selects exit before account is created
* Device loses power before "Create Account" is selected
* Application stops working
*****
#### Use Case 2
*****
* Name: Add Event without document upload
* Actors: User, Application, Database
* Precondition: User has an event
* Trigger: User wants to share event with other users

###### Good Flow
* User Selects Add event
* User types data in text box he/she wants to include for Event
* User selects Save
* Applications stores all information in the Database
* Application displays new event to all users

###### Alternate Flow
* User signs out before adding Event
* Device loses power before selcting "Add Event"
* User Unable to login in
* User does not save event before exiting
* Application does not call database transaction
* User decides not to add Event

****
Use Case 3
****
* Name: Add Document
* Actors: User, Application, Database
* Precondition: User has a document in one of the excepted formats
* Trigger: User wants to share the document with other users

###### Good Flow
* User Selects "Upload New Document"
* User browses device for and selects document
* User types name for new document in text box
* User selects "Upload Document"
* Applications stores all information in the Database
* Application displays link for new doucument with text user entered to all users

###### Alternate Flow
* User signs out before adding Document
* Device loses power before selcting completing task
* User Unable to login in
* User cannot find file on devise
* File is corrupt
* File is not in format accepted by application
* User does not name the file before selecting "Upload Document"
* User does not "Upload Document" before exiting
* Application does not call database transaction
* User decides not to add Document
