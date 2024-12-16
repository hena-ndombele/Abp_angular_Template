import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: true,
  application: {
    baseUrl,
    name: 'TemplateAngular',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44311/',
    redirectUri: baseUrl,
    clientId: 'TemplateAngular_App',
    responseType: 'code',
    scope: 'offline_access TemplateAngular',
    requireHttps: true
  },
  apis: {
    default: {
      url: 'https://localhost:44311',
      rootNamespace: 'TemplateAngular',
    },
  },
} as Environment;
