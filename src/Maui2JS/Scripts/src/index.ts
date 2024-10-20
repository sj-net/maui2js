import { geoLocation } from './GeoLocation';
import { vibration } from './Vibration';
import { permissions } from './Permissions';

// Use an IIFE to attach the class to the global scope
((global: any) => {
    global.maui2js = {
        geoLocation,
        vibration,
        permissions
    }; // Attach the class to the global scope
})(typeof globalThis !== 'undefined' ? globalThis : this); // Use globalThis or this to avoid window
