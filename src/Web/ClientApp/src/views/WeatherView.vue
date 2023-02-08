<script setup>
import WeatherList from '@/components/WeatherList.vue'
import WeatherForecastSkeleton from '@/components/WeatherForecastSkeleton.vue'
</script>

<template>
  <div class="py-10">
    <header>
      <div class="mx-auto max-w-3xl lg:max-w-7xl px-4 sm:px-6 lg:px-8">
        <h1 class="text-3xl font-bold leading-tight tracking-tight text-gray-900">Weather</h1>
      </div>
    </header>
    <main>
      <div class="mx-auto max-w-3xl lg:max-w-7xl sm:px-6 lg:px-8">
        <!-- Content -->
        <div class="px-4 py-8 sm:px-0">
          <div class="pb-2">
            <h3 class="text-lg font-medium leading-6 text-gray-900">Weather forecasts for next 7 days</h3>
          </div>
          <div class="lg:grid lg:grid-cols-12 lg:gap-x-16">
            <Suspense>
              <WeatherList />
              <template #fallback>
                <ol class="mt-4 divide-y divide-gray-100 text-sm leading-6 lg:col-span-7 xl:col-span-8">
                  <WeatherForecastSkeleton v-for="index in 7" key="index" />
                </ol>
              </template>
            </Suspense>
          </div>
        </div>
        <!-- /End Content -->
      </div>
    </main>
  </div>
</template>