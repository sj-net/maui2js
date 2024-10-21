declare class Vibration {
    startVibration(time: number | TimeSpanFormat): Promise<void>;
    stopVibration(): Promise<void>;
}
export declare const vibration: Vibration;
export {};
