# Dialog

## Uses [Blazor JavaScript Interop](https://learn.microsoft.com/en-us/aspnet/core/blazor/javascript-interoperability/?view=aspnetcore-8.0)

## Description

`Dialog` is a TypeScript class that provides methods for displaying alert, confirmation, and prompt dialogs in a web application. It allows user interaction through various dialog types and enhances user experience by providing immediate feedback.

## Usage

### Accessing the Dialog Object

After including the script, you can access the `dialog` instance as follows:

```javascript
const { dialog } = maui2js;
```
Methods

1. To display an alert dialog with a message, use the showAlert method:
```javascript
dialog.showAlert('This is an alert message!', 'Alert Title')
    .then(() => {
        console.log('Alert dismissed.');
    });
```
2. To show a confirmation dialog that returns a boolean value based on user response, use:

```javascript
dialog.showConfirm('Are you sure you want to proceed?', 'Confirm Action')
    .then((result) => {
        if (result) {
            console.log('User confirmed action.');
        } else {
            console.log('User canceled action.');
        }
    });
```
3. To prompt the user for input, use the showPrompt method:
```javascript
dialog.showPrompt('Please enter your name:', 'Name Prompt', 'Default Name')
    .then((input) => {
        if (input !== null) {
            console.log(`User entered: ${input}`);
        } else {
            console.log('User canceled the prompt.');
        }
    });
```