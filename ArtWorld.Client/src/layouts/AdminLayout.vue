<template>
    <div class="bg-gray-800 font-sans leading-normal tracking-normal mt-12">
        <Navbar />
        <main>
            <div class="flex flex-col md:flex-row">
                <Sidebar /> 
                <section class="w-full">
                    <div id="main" class="main-content h-full bg-gray-100 mt-12 md:mt-2 pb-24 md:pb-5">  
                        <slot />
                    </div>
                </section>
            </div>
        </main>
    </div>
</template>

<script>
import Navbar from '@/components/admin/Navbar.vue'
import Sidebar from '@/components/admin/Sidebar.vue'

export default {
    name: 'AdminLayout',
    components: {
        Navbar,
        Sidebar
    }
}
</script>