const nameof = <T>(name: Extract<keyof T, string>): string => name;
type TimeSpanFormat = `${number}:${number}:${number}`;  // Basic format enforcement