import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: true,
  application: {
    baseUrl,
    name: 'NutritionChecker',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44345',
    redirectUri: baseUrl,
    clientId: 'NutritionChecker_App',
    responseType: 'code',
    scope: 'offline_access NutritionChecker',
    requireHttps: true
  },
  apis: {
    default: {
      url: 'https://localhost:44345',
      rootNamespace: 'Remi.NutritionChecker',
    },
  },
} as Environment;
