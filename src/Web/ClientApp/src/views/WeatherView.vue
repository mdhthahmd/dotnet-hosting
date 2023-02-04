<script setup>
import {
  CalendarIcon,
} from '@heroicons/vue/20/solid'

const forecasts = [
  {
    id: 1,
    date: "February 05 2023, Sunday",
    time: "21:50",
    dateTime: "2/5/2023 9:50:40 PM",
    summary: "Sweltering",
    image: "https://bmcdn.nl/assets/weather-icons/v3.0/fill/svg/extreme.svg",
    temperature: 31
  },
  {
    id: 2,
    date: "February 06 2023, Monday",
    time: "21:50",
    dateTime: "2/6/2023 9:50:40 PM",
    summary: "Sweltering",
    image: "https://bmcdn.nl/assets/weather-icons/v3.0/fill/svg/hurricane.svg",
    temperature: 48
  },
  {
    id: 3,
    date: "February 07 2023, Tuesday",
    time: "21:50",
    dateTime: "2/7/2023 9:50:40 PM",
    summary: "Hot",
    image: "https://bmcdn.nl/assets/weather-icons/v3.0/fill/svg/overcast-day-fog.svg",
    temperature: 16
  },
  {
    id: 4,
    date: "February 08 2023, Wednesday",
    time: "21:50",
    dateTime: "2/8/2023 9:50:40 PM",
    summary: "Warm",
    image: "https://bmcdn.nl/assets/weather-icons/v3.0/fill/svg/solar-eclipse.svg",
    temperature: 30
  },
  {
    id: 5,
    date: "February 09 2023, Thursday",
    time: "21:50",
    dateTime: "2/9/2023 9:50:40 PM",
    summary: "Bracing",
    image: "https://bmcdn.nl/assets/weather-icons/v3.0/fill/svg/thunderstorms-day-overcast-snow.svg",
    temperature: 19
  },
  {
    id: 6,
    date: "February 10 2023, Friday",
    time: "21:50",
    dateTime: "2/10/2023 9:50:40 PM",
    summary: "Hot",
    image: "https://bmcdn.nl/assets/weather-icons/v3.0/fill/svg/hurricane.svg",
    temperature: -3
  },
  {
    id: 7,
    date: "February 11 2023, Saturday",
    time: "21:50",
    dateTime: "2/11/2023 9:50:40 PM",
    summary: "Chilly",
    image: "https://bmcdn.nl/assets/weather-icons/v3.0/fill/svg/solar-eclipse.svg",
    temperature: 29
  }
]

</script>

<template>
  <div class="pt-10 pb-4">
    <header>
      <div class="mx-auto max-w-7xl px-4 sm:px-6 lg:px-8">
        <h1 class="text-3xl font-bold leading-tight tracking-tight text-gray-900">Weather</h1>
      </div>
    </header>
    <main>
      <div class="mx-auto max-w-7xl sm:px-6 lg:px-8">
        <!-- Replace with your content -->
        <div>
          <h2 class="text-lg font-semibold text-gray-900 pt-4">Forecasts for next few days</h2>
          <div class="lg:grid lg:grid-cols-12 lg:gap-x-16">
            <div class="mt-10 text-center lg:col-start-8 lg:col-end-13 lg:row-start-1 lg:mt-9 xl:col-start-9">
              <button type="button"
                class="w-full rounded-md border border-transparent bg-indigo-600 py-2 px-4 text-sm font-medium text-white shadow hover:bg-indigo-700 focus:outline-none focus:ring-2 focus:ring-indigo-500 focus:ring-offset-2">Reload</button>
            </div>
            <ol class="mt-4 divide-y divide-gray-100 text-sm leading-6 lg:col-span-7 xl:col-span-8">
              <li v-for="forecast in forecasts" :key="forecast.id" class="relative flex space-x-6 py-6 xl:static">
                <img :src="forecast.image" alt="" class="h-14 w-14 flex-none rounded-full" />
                <div class="flex-auto">
                  <h3 class="pr-10 font-semibold text-gray-900 xl:pr-0">{{ forecast.summary }}</h3>
                  <dl class="mt-2 flex flex-col text-gray-500 xl:flex-row">
                    <div class="flex items-start space-x-3">
                      <dt class="mt-0.5">
                        <span class="sr-only">Date</span>
                        <CalendarIcon class="h-5 w-5 text-gray-400" aria-hidden="true" />
                      </dt>
                      <dd>
                        <time :datetime="forecast.datetime">{{ forecast.date }} at {{ forecast.time }}</time>
                      </dd>
                    </div>

                  </dl>
                </div>

              </li>
            </ol>
          </div>
        </div>
        <!-- /End replace -->
      </div>
    </main>
  </div>
</template>