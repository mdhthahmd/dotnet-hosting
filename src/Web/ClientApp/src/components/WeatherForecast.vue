<script setup>
import { CalendarIcon } from '@heroicons/vue/20/solid'

defineProps({
    forecast: { type: Object }
})

</script>
<template>
    <li class="relative flex space-x-6 py-6 xl:static">
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
</template>