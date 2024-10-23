import { ASSEMBLY_NAME } from "./constants";

class Dialog {
    /**
   * Displays an alert dialog with a title and message.
   * This is similar to a C# DisplayAlert method.
   * @param message - The message to display in the alert.
   * @param title - The title of the alert (default: 'Alert').
   * @returns A Promise that resolves when the alert is closed.
   */
    async showAlertAsync(message: string, title: string = "Alert"): Promise<void> {
        return new Promise<void>((resolve) => {
            // Use the browser's built-in alert function to show the message
            alert(`${title}: ${message}`);
            // Resolve the promise after the user closes the alert
            resolve();
        });
    }

    /**
     * Displays a confirmation dialog with a title and message.
     * This is similar to a C# DisplayAlert with 'OK' and 'Cancel' buttons.
     * @param message - The message to display in the confirmation dialog.
     * @param title - The title of the confirmation dialog (default: 'Confirm').
     * @returns A Promise that resolves to true if the user clicks 'OK', false otherwise.
     */
    async showConfirmAsync(message: string, title: string = "Confirm"): Promise<boolean> {
        return new Promise<boolean>((resolve) => {
            // Use the browser's built-in confirm function to show the message
            const isConfirmed = confirm(`${title}: ${message}`);
            // Resolve the promise with true if OK is clicked, false otherwise
            resolve(isConfirmed);
        });
    }

    /**
     * Displays a prompt dialog with a title and message, allowing the user to input a value.
     * This is similar to a C# DisplayPromptAsync method.
     * @param message - The message to display in the prompt dialog.
     * @param title - The title of the prompt dialog (default: 'Prompt').
     * @param defaultValue - The default value in the input field (default: empty string).
     * @returns A Promise that resolves with the user's input or an empty string if cancelled.
     */
    async showPromptAsync(message: string, title: string = "Prompt", defaultValue: string = ""): Promise<string> {
        return new Promise<string>((resolve) => {
            // Use the browser's built-in prompt function to show the message
            const input = prompt(`${title}: ${message}`, defaultValue);
            // Resolve the promise with the input value or an empty string if cancelled
            resolve(input || "");
        });
    }
}

export const dialog = new Dialog();
