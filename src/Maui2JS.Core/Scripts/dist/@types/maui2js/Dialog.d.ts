declare class Dialog {
    /**
   * Displays an alert dialog with a title and message.
   * This is similar to a C# DisplayAlert method.
   * @param message - The message to display in the alert.
   * @param title - The title of the alert (default: 'Alert').
   * @returns A Promise that resolves when the alert is closed.
   */
    showAlertAsync(message: string, title?: string): Promise<void>;
    /**
     * Displays a confirmation dialog with a title and message.
     * This is similar to a C# DisplayAlert with 'OK' and 'Cancel' buttons.
     * @param message - The message to display in the confirmation dialog.
     * @param title - The title of the confirmation dialog (default: 'Confirm').
     * @returns A Promise that resolves to true if the user clicks 'OK', false otherwise.
     */
    showConfirmAsync(message: string, title?: string): Promise<boolean>;
    /**
     * Displays a prompt dialog with a title and message, allowing the user to input a value.
     * This is similar to a C# DisplayPromptAsync method.
     * @param message - The message to display in the prompt dialog.
     * @param title - The title of the prompt dialog (default: 'Prompt').
     * @param defaultValue - The default value in the input field (default: empty string).
     * @returns A Promise that resolves with the user's input or an empty string if cancelled.
     */
    showPromptAsync(message: string, title?: string, defaultValue?: string): Promise<string>;
}
export declare const dialog: Dialog;
export {};
