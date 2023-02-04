import { createRouter, createWebHistory } from "vue-router";
import HomeView from "../views/HomeView.vue";
import CounterView from "../views/CounterView.vue";
import WeatherView from '../views/WeatherView.vue'

const router = createRouter({
  history: createWebHistory(import.meta.env.BASE_URL),
  routes: [
    {
      path: "/",
      name: "home",
      component: HomeView,
    },
    {
        path: "/counter",
        name: "counter",
        component: CounterView,
    },
    {
        path: "/weather",
        name: "weather",
        component: WeatherView,
    },
  ],
});

export default router;
