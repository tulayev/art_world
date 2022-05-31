import { createApp } from 'vue'
import App from './App.vue'
import router from './router'
import store from './store'
import '../src/assets/styles/style.css'

import VueProgressBar from '@aacassandra/vue3-progressbar'

const options = {
    color: "#f162ff",
    failedColor: "#874b4b",
    thickness: "20px",
    transition: {
        speed: "0.2s",
        opacity: "0.6s",
        termination: 300,
    },
    position: "relative",
    autoRevert: true,
    inverse: false,
};

const app = createApp(App)

app.use(VueProgressBar, options).use(store).use(router)

app.mount('#app')
