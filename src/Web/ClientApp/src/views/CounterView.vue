<script setup>
import { ref } from 'vue'

const count = ref(0)
</script>

<template>
    <div class="pt-10 pb-4">
        <header>
            <div class="mx-auto max-w-7xl px-4 sm:px-6 lg:px-8">
                <h1 class="text-3xl font-bold leading-tight tracking-tight text-gray-900">Counter</h1>
            </div>
        </header>
        <main>
            <div class="mx-auto max-w-7xl px-4 sm:px-6 lg:px-8">
                <!-- Replace with your content -->
                <div class="bg-gray-50 sm:rounded-lg">
                    <div class="py-5">
                        <h3 class="text-lg font-medium leading-6 text-gray-900">Lets Test State Managment?</h3>
                        <div class="mt-2 max-w-xl text-sm text-gray-500">
                            <p>Please click the below button, this will increment a stored value. So far you have cicked 
                                <span class="font-semibold text-indigo-600">{{ count }}</span> times!.
                            </p>
                        </div>
                        <div class="mt-5">
                            <button type="button"
                                @click="count++"
                                class="inline-flex items-center rounded-md border border-gray-300 bg-white px-4 py-2 font-medium text-gray-700 shadow-sm hover:bg-gray-50 focus:outline-none focus:ring-2 focus:ring-indigo-500 focus:ring-offset-2 sm:text-sm">
                                Click me
                            </button>
                        </div>
                    </div>
                </div>
                <!-- /End replace -->
            </div>
        </main>
    </div>
</template>