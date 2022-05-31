<template>

    <div class="bg-gray-900 text-white">
        <Header/>
        
        <slot />

        <Footer />
    </div>

</template>

<script>
import Header from '@/components/Header.vue'
import Footer from '@/components/Footer.vue'

export default {
	name: 'DefaultLayout',
    components: {
		Header,
		Footer
	}
}
</script>