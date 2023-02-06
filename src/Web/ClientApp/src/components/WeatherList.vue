<script setup>

import { ref } from 'vue'
import axios from 'axios';
import WeatherForecast from '@/components/WeatherForecast.vue';

let forecasts = ref(null)

await axios.get("https://localhost:5001/api/weather", { headers: { "Access-Control-Allow-Origin" : "*"} })
    .then(response => {
        forecasts.value = response.data
    });

</script>

<template>
    <ol class="mt-4 divide-y divide-gray-100 text-sm leading-6 lg:col-span-7 xl:col-span-8">
        <WeatherForecast v-for="forecast in forecasts" :key="forecast.id" :forecast="forecast" />
    </ol>
</template>

