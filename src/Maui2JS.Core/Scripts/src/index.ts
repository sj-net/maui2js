import { geoLocation } from './GeoLocation';
import { vibration } from './Vibration';
import { permissions } from './Permissions';
import { dialog } from './Dialog';
import { localNotification } from './LocalNotification';

// Use an IIFE to attach the class to the global scope
((global: any) => {
    global.maui2js = {
        geoLocation,
        vibration,
        permissions,
        dialog,
        localNotification
    }; // Attach the class to the global scope
})(typeof globalThis !== 'undefined' ? globalThis : this); // Use globalThis or this to avoid window
