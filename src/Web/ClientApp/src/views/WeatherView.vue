<script setup>
import WeatherList from '@/components/WeatherList.vue'
import WeatherForecastSkeleton from '@/components/WeatherForecastSkeleton.vue'
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
        <div>
        <h2 class="text-lg font-semibold text-gray-900 pt-4">Forecasts for next few days</h2>
        <div class="lg:grid lg:grid-cols-12 lg:gap-x-16">
            <!-- <div class="mt-10 text-center lg:col-start-8 lg:col-end-13 lg:row-start-1 lg:mt-9 xl:col-start-9">
                <button type="button" @click="getWeahterData()"
                    class="w-full rounded-md border border-transparent bg-red-600 py-2 px-4 text-sm font-medium text-white shadow hover:bg-red-700 focus:outline-none focus:ring-2 focus:ring-red-500 focus:ring-offset-2">Reload</button>
            </div> -->
            <Suspense>
               <WeatherList/>
                <template #fallback>
                    <ol class="mt-4 divide-y divide-gray-100 text-sm leading-6 lg:col-span-7 xl:col-span-8">
                        <WeatherForecastSkeleton v-for="index in 7" key="index" />
                    </ol>
                </template>
            </Suspense>
        </div>
    </div>
      </div>
    </main>
  </div>
</template>