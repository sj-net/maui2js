declare const nameof: <T>(name: Extract<keyof T, string>) => string;
type TimeSpanFormat = `${number}:${number}:${number}`;
