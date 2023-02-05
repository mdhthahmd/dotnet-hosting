import { defineConfig } from 'vite'
import { fileURLToPath, URL } from 'node:url'
import vue from '@vitejs/plugin-vue'
import basicSsl from '@vitejs/plugin-basic-ssl'

// https://vitejs.dev/config/
export default defineConfig({
  plugins: [
    basicSsl(),
    vue(), 
  ],
  resolve: {
    alias: {
      '@': fileURLToPath(new URL('./src', import.meta.url))
    }
  },
  server:
  {
    proxy: {
      '/api': {
           target: 'https://127.0.0.1:7243/',
           changeOrigin: true,
           secure: false,      
           ws: true,
       }
  }
}
})
