<template>

    <default-layout>
    
        <main class="py-8">
            <div class="container mx-auto px-4">
                <div class="anime-details border-b border-gray-800 pb-12 flex flex-col lg:flex-row">
                    <div class="flex-none">
                        <img 
                            src="@/assets/images/naruto.jpg" 
                            alt="cover" 
                        />
                    </div>
                    <div class="ml-12 mr-64">
                        <h2 class="font-bold text-6xl leading-tight mt-1">
                            Naruto Shippuuden
                        </h2>
                        <div class="text-gray-400">
                            <span>Жанры (боевик, драма...)</span>
                            &middot;
                            <span>Тип (TV, Movie, OVA...)</span>
                            &middot;
                            <span>Студия (MadHouse, Pierrot...)</span>
                        </div>
        
                        <p class="mt-12">
                        Описание аниме
                        </p>
        
                        <div class="mt-12">
                            <a href="#" class="inline-flex bg-blue-500 text-white font-semibold px-4 py-4 hover:bg-blue-600 rounded transition ease-in-out duration-150">
                                <img src="@/assets/images/play.svg" alt="Play Button" />
                                <span class="ml-2">Посмотреть трейлер</span>
                            </a>
                        </div>
                    </div>
                </div> 
        
                <div class="images-container border-b border-gray-800 pb-12 mt-8">
                    <h2 class="text-blue-500 uppercase .tracking-wide font-semibold">
                        Скриншоты
                    </h2>
                    <div class="grid grid-cols-1 md:grid-cols-2 lg:grid-cols-5 gap-12 mt-8">
                        <div>
                            <a href="#">
                                <img 
                                    src="@/assets/images/naruto-screenshot.png" 
                                    alt="screenshot" 
                                    class="hover:opacity-75 transition ease-in-out duration-150"
                                />
                            </a>
                        </div>

                        <div>
                            <a href="#">
                                <img 
                                    src="@/assets/images/naruto-screenshot.png" 
                                    alt="screenshot" 
                                    class="hover:opacity-75 transition ease-in-out duration-150"
                                />
                            </a>
                        </div>
                    </div>
                </div> 
        
                <div class="more-info-container mt-8">
                    <h2 class="text-blue-500 uppercase tracking-wide font-semibold mb-3">Дополнительная информация</h2>
                    <div class="text-sm">
                        <br />
                        <br />
                        Количество серий: 500
                    </div>
                </div> 
            </div>
        </main>

    </default-layout>

</template>

<script>
import DefaultLayout from '@/layouts/DefaultLayout.vue'

export default {
	name: 'Details',
    components: {
        DefaultLayout
	},
	setup() {
		
	}
}
</script>