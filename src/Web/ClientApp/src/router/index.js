import { createRouter, createWebHistory } from "vue-router";
import HomeView from "@/views/HomeView.vue";
import CounterView from "@/views/CounterView.vue";
import WeatherView from "@/views/WeatherView.vue";
import PageNotFoundView from "@/views/PageNotFoundView.vue";

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
    {
      path: "/:pathMatch(.*)*",
      name: "not-found",
      component: PageNotFoundView,
  },
  ],
});

export default router;
