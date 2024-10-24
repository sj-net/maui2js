declare class LocalNotification {
    /**
     * Sends an instant notification.
     * @param title - The notification title.
     * @param message - The notification message.
     * @param smallIconResourceId - Optional ID of the small icon resource.
     * @returns A promise that resolves to true if the notification was sent successfully, false otherwise.
     */
    sendInstantNotificationAsync(title: string, message: string, smallIconResourceId?: number): Promise<boolean>;
    /**
     * Schedules a notification for a later time.
     * @param title - The notification title.
     * @param message - The notification message.
     * @param notifyTime - Date object representing the time when the notification should be triggered.
     * @param smallIconResourceId - Optional ID of the small icon resource.
     * @returns A promise that resolves to true if the notification was scheduled successfully, false otherwise.
     */
    scheduleNotificationAsync(title: string, message: string, notifyTime: Date, smallIconResourceId?: number): Promise<boolean>;
}
export declare const localNotification: LocalNotification;
export {};
