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
        return new Promise<void>(async (resolve) => {
            try {
                await DotNet.invokeMethodAsync(ASSEMBLY_NAME, `ShowAlertAsync`, message, title);
            } catch (error: any) {
                console.error(`Error: ${error.message}`);
            } resolve();
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
        return new Promise<boolean>(async (resolve) => {
            try {
                resolve(await DotNet.invokeMethodAsync(ASSEMBLY_NAME, `ShowConfirmAsync`, message, title));
                return;
            } catch (error: any) {
                console.error(`Error: ${error.message}`);
                resolve(false);
            }
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
        return new Promise<string>(async (resolve) => {
            try {
                resolve(await DotNet.invokeMethodAsync(ASSEMBLY_NAME, `ShowPromptAsync`, message, title, defaultValue));
            } catch (error: any) {
                console.error(`Error: ${error.message}`);
                resolve("");
            }
        });
    }
}

export const dialog = new Dialog();
