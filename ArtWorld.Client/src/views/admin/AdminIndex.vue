<template>
    <admin-layout>
        <div class="bg-gray-800 pt-3">
            <div class="bg-gradient-to-r from-blue-900 to-gray-800 p-4 shadow text-2xl text-white">
                <RouterView />
            </div>
        </div>
    </admin-layout>
</template>

<script>
import AdminLayout from '@/layouts/AdminLayout.vue'

export default {
	name: 'Index',
    components: {
		AdminLayout
	},
	setup() {
		
	}
}
</script>