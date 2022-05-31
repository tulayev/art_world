<template>
    <default-layout>
        
        <main class="py-8">
            <div class="container mx-auto px-4">

                <h2 class="text-blue-500 uppercase tracking-wide font-semibold">
                    Популярные аниме
                </h2>

                <div class="popular-anime text-sm grid grid-cols-1 md:grid-cols-2 lg:grid-cols-5 xl:grid-cols-6 gap-12 border-b border-gray-800 pb-16">
                
                    <div class="anime mt-8">
                        <div class="relative inline-block">
                            <router-link :to="{ name: 'details', params: { id: 1 }}">
                                <img 
                                    src="@/assets/images/naruto.jpg" 
                                    alt="anime poster" 
                                    class="hover:opacity-75 transition ease-in-out duration-150 w-[170px] h-[250px]"
                                />
                            </router-link>
                            <div id="" class="absolute bottom-[-20px] right-[-20px] w-16 h-16 bg-gray-800 rounded-full text-sm">
                            </div>
                        </div>
            
                        <a href="#" class="block text-base font-semibold leading-tight hover:text-gray-400 mt-8">
                            Naruto Shippuuden
                        </a>
                        <div class="text-gray-400 mt-1">TV</div>
                    </div>

                    <div class="anime mt-8">
                        <div class="relative inline-block">
                            <div class="bg-gray-800 w-[170px] h-[250px]"></div>
                        </div>

                        <div class="block text-transparent text-lg bg-gray-700 rounded leading-tight mt-4">
                            Title goes here
                        </div>
                        <div class="inline-block text-transparent bg-gray-700 rounded mt-3">
                            TV Movie Ova (type)
                        </div>
                    </div>
                
                </div>
        
                <div class="flex flex-col lg:flex-row my-10">

                    <div class="recently-reviewed w-full lg:w-3/4 mr-0 lg:mr-32">

                        <h2 class="text-blue-500 uppercase tracking-wide font-semibold">
                            Недавно просмотренные
                        </h2>
                        
                        <div class="recently-reviewed-container space-y-12 mt-8">

                            <div class="anime bg-gray-800 rounded-lg shadow-md flex px-6 py-6">
                                <div class="relative flex-none">
                                    <a href="#">
                                        <img 
                                            src="@/assets/images/naruto.jpg" 
                                            alt="anime poster" 
                                            class="w-48 hover:opacity-75 transition ease-in-out duration-150"
                                        />
                                    </a>
                                    <div id="" class="absolute bottom-[-20px] right-[-20px] w-16 h-16 bg-gray-900 rounded-full text-sm">
                                    </div>
                                </div>
                    
                                <div class="ml-12">
                                    <a href="#" class="block text-lg font-semibold leading-tight hover:text-gray-400 mt-4"></a>
                                    <div class="text-gray-400 mt-1"></div>
                                    <p class="mt-6 text-gray-400 hidden lg:block">
                                        Lorem ipsum dolor sit amet, consectetur adipisicing elit. Accusantium aliquid cum cupiditate ducimus, earum esse est eveniet ipsa laborum mollitia nihil obcaecati odio omnis quidem repellat repudiandae voluptatem voluptates! Deserunt.
                                    </p>
                                </div>
                            </div>

                            <div class="spinner mt-8"></div>

                        </div>

                    </div>
        
                    <div class="most-anticipated  lg:w-1/4 mt-12 lg:mt-0">

                        <h2 class="text-blue-500 uppercase tracking-wide font-semibold">
                            Самые ожидаемые
                        </h2>
                        
                        <div class="most-anticipated-container space-y-10 mt-8 mb-10">

                            <div class="anime flex">
                                <a href="#">
                                    <img 
                                        src="@/assets/images/naruto.jpg" 
                                        alt="anime poster" 
                                        class="w-16 hover:opacity-75 transition ease-in-out duration-150"
                                    />
                                </a>
                    
                                <div class="ml-4">
                                    <a href="#" class="hover:text-gray-300"></a>
                                    <div class="text-gray-400 text-sm mt-1"></div>
                                </div>
                            </div>

                            <div class="spinner mt-8"></div>

                        </div>
        
                        <h2 class="text-blue-500 uppercase tracking-wide font-semibold">
                            Скоро
                        </h2>
                        
                        <div class="coming-soon-container space-y-10 mt-8">
                            <div class="anime flex">
                                <a href="#">
                                    <img 
                                        src="@/assets/images/naruto.jpg" 
                                        alt="anime poster" 
                                        class="w-16 hover:opacity-75 transition ease-in-out duration-150"
                                    />
                                </a>
                    
                                <div class="ml-4">
                                    <a href="#" class="hover:text-gray-300"></a>
                                    <div class="text-gray-400 text-sm mt-1"></div>
                                </div>
                            </div>

                            <div class="spinner mt-8"></div>

                        </div>
                    </div>
                </div>
            </div>
        </main>

    </default-layout>

</template>

<script>
import DefaultLayout from '@/layouts/DefaultLayout.vue'
export default {
	name: 'Index',
    components: {
        DefaultLayout
	},
	setup() {
		
	}
}
</script>