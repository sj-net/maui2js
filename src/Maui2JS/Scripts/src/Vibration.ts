import { ASSEMBLY_NAME } from "./constants";

class Vibration {
    /*
    * Vibrate for a specified amount of time.
    * @param time - The duration of the vibration in milliseconds or as a hh:mm:ss object. Only a maximum of 5 seconds is allowed as per MAUI.
    */
    async startVibration(time: number | TimeSpanFormat) {
        try {
            await DotNet.invokeMethodAsync(ASSEMBLY_NAME, `StartVibration`, time);
        } catch (error: any) {
            console.error(`Error vibrating: ${error.message}`);
        }
    }

    /*
    * Cancel the current vibration.
    */
    async stopVibration() {
        try {
            await DotNet.invokeMethodAsync(ASSEMBLY_NAME, `StopVibration`);
        } catch (error: any) {
            console.error(`Error canceling vibration: ${error.message}`);
        }
    }
}

export const vibration = new Vibration();
