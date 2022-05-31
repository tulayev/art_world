<template>
	<h1 class="font-bold pl-2">Добавить аниме</h1>

	<div class="w-full mt-4">
		<form 
			@submit.prevent="submit"
			class="bg-white shadow-md rounded px-8 pt-6 pb-8 mb-4"
			enctype="multipart/form-data"
		>
			<div class="mb-4">
				<label class="block text-gray-700 text-sm font-bold mb-2" for="title">
					Название
				</label>
				<input
					v-model="title" 
					class="shadow appearance-none border rounded w-full py-2 px-3 text-gray-700 leading-tight focus:outline-none focus:shadow-outline" 
					id="title" 
					type="text" 
					placeholder="Название"
				/>
			</div>

			<div class="mb-4">
				<label class="block text-gray-700 text-sm font-bold mb-2" for="titleRomadzi">
					Название (ромадзи)
				</label>
				<input 
					v-model="titleRomadzi" 
					class="shadow appearance-none border rounded w-full py-2 px-3 text-gray-700 leading-tight focus:outline-none focus:shadow-outline" 
					id="titleRomadzi" 
					type="text" 
					placeholder="Например: Mirai Nikki"
				/>
			</div>

			<div class="mb-4">
				<label class="block text-gray-700 text-sm font-bold mb-2" for="rating">
					Рейтинг
				</label>
				<input 
					v-model="rating"
					class="shadow appearance-none border rounded w-full py-2 px-3 text-gray-700 leading-tight focus:outline-none focus:shadow-outline" 
					id="rating" 
					type="number" 
					placeholder="Рейтинг"
				/>
			</div>

			<div class="mb-4">
				<label class="block text-gray-700 text-sm font-bold mb-2" for="type">
					Тип
				</label>
				<input 
					v-model="type"
					class="shadow appearance-none border rounded w-full py-2 px-3 text-gray-700 leading-tight focus:outline-none focus:shadow-outline" 
					id="type" 
					type="text" 
					placeholder="Тип (TV, Movie, OVA...)"
				/>
			</div>

			<div class="mb-4">
				<label class="block text-gray-700 text-sm font-bold mb-2" for="description">
					Описание
				</label>
				<textarea 
					v-model="description"
					class="shadow appearance-none border rounded w-full py-2 px-3 text-gray-700 leading-tight focus:outline-none focus:shadow-outline" 
					id="description" 
					placeholder="Описание"
				></textarea>
			</div>

			<div class="mb-4">
				<label class="block text-gray-700 text-sm font-bold mb-2" for="info">
					Дополнительная информация
				</label>
				<textarea 
					v-model="info"
					class="shadow appearance-none border rounded w-full py-2 px-3 text-gray-700 leading-tight focus:outline-none focus:shadow-outline" 
					id="info" 
					placeholder="Дополнительная информация"
				></textarea>
			</div>

			<div class="mb-4">
				<label class="block text-gray-700 text-sm font-bold mb-2" for="studio">
					Выберите студию
				</label>
				<select 
					v-model="studio"
					class="shadow appearance-none border rounded w-full py-2 px-3 text-gray-700 leading-tight focus:outline-none focus:shadow-outline"
					id="studio"
				>
					<option selected disabled>-----</option>
					<option value="1">Pierrot</option>
    			</select>
			</div>

			<div class="mb-4">
				<label class="block text-gray-700 text-sm font-bold mb-2" for="genre">
					Выберите жанры
				</label>
				<select 
					v-model="genre"
					@change="onSelected"
					class="shadow appearance-none border rounded w-full py-2 px-3 text-gray-700 leading-tight focus:outline-none focus:shadow-outline"
					id="genre"
				>
					<option selected disabled>-----</option>
					<option value="1">Приключения</option>
					<option value="2">Боевик</option>
					<option value="3">Сьёнен</option>
    			</select>
			</div>

			<div class="mb-4">
				<label class="block text-gray-700 text-sm font-bold mb-2" for="image">
					Загрузить постер
				</label>
				<input
					v-model="imageName"
					type="hidden"
				/>
				<input
					@change="handleImage" 
					class="block w-full py-2 px-3 text-sm text-gray-900 bg-gray-50 rounded-lg border border-gray-300 cursor-pointer dark:text-gray-400 focus:outline-none dark:bg-gray-700 dark:border-gray-600 dark:placeholder-gray-400" 
					id="image" 
					type="file"
				/>
			</div>

			<div class="mb-4">
				<label class="block text-gray-700 text-sm font-bold mb-2" for="images">
					Загрузить картинки
				</label>
				<input
					v-model="imagesNames"
					type="hidden"
				/>
				<input
					@change="handleImages" 
					class="block w-full py-2 px-3 text-sm text-gray-900 bg-gray-50 rounded-lg border border-gray-300 cursor-pointer dark:text-gray-400 focus:outline-none dark:bg-gray-700 dark:border-gray-600 dark:placeholder-gray-400" 
					id="images"
					type="file"
					multiple
				/>
			</div>

			<div class="mb-4">
				<label class="block text-gray-700 text-sm font-bold mb-2" for="video">
					Загрузить трейлер
				</label>
				<input
					v-model="videoName"
					type="hidden"
				/>
				<input 
					@change="handleVideo"
					class="block w-full py-2 px-3 text-sm text-gray-900 bg-gray-50 rounded-lg border border-gray-300 cursor-pointer dark:text-gray-400 focus:outline-none dark:bg-gray-700 dark:border-gray-600 dark:placeholder-gray-400" 
					id="video" 
					type="file"
					accept="video/*"
				/>
				<div class="my-2">
					<div class="text-gray-700 text-sm font-bold" v-if="uploadFinished.length > 0">
						{{ uploadFinished }}
					</div>
					<div v-else>
						<vue-progress-bar></vue-progress-bar>
					</div>
				</div>
			</div>

			<div class="flex items-center justify-between">
				<button
					:disabled="btnDisabled" 
					:class="{'disabled' : btnDisabled}"
					class="bg-blue-500 hover:bg-blue-700 text-white font-bold py-2 px-4 rounded focus:outline-none focus:shadow-outline" 
					type="submit"
				>
					Сохранить
				</button>
			</div>
		</form>
	</div>
</template>

<script>
import { ref } from '@vue/reactivity'
import { getCurrentInstance } from 'vue'
import axios from '@/plugins/axios'

export default {
	name: 'Create',

	setup() {
		const title = ref('')
		const titleRomadzi = ref('')
		const rating = ref(0)
		const type = ref('')
		const description = ref('')
		const info = ref('')
		const studio = ref(0)
		const genre = ref('')
		const imageName = ref('')
		const imagesNames = ref('')
		const videoName = ref('')
		const genresArray = []
		const btnDisabled = ref(false)
		const internalInstance = getCurrentInstance()
		const uploadFinished = ref('')
		
		const handleImage = async (e) => {
			const image = e.target.files[0]

			if (!image) {
				return
			}

			const form = new FormData()
			form.append('image', image)

			try {
				btnDisabled.value = true
				const res = await axios.post('/api/image', form)

				if (res.status === 200 && res.statusText === 'OK') {
					imageName.value = res.data
					btnDisabled.value = false
				}
			}
			catch (e) {
				console.log(e.message)
			}
		}

		const handleImages = async (e) => {
			const images = e.target.files

			if (!images) {
				return
			}

			const form = new FormData()

			for (let img of images) {
      			form.append(img.name, img)
			}

			try {
				btnDisabled.value = true
				const res = await axios.post('/api/images', form)

				if (res.status === 200 && res.statusText === 'OK') {
					imagesNames.value = res.data
					btnDisabled.value = false
				}
			}
			catch (e) {
				console.log(e.message)
			}
		}

		const handleVideo = async (e) => {
			const video = e.target.files[0]

			if (!video) {
				return
			}

			const form = new FormData()
			form.append('video', video)

			try {
				internalInstance.appContext.config.globalProperties.$Progress.start()
				btnDisabled.value = true
				const res = await axios.post('/api/videos', form, {
					onUploadProgress: progressEvent => {
						let percentComplete = progressEvent.loaded / progressEvent.total
						percentComplete = parseInt(percentComplete * 100)
    				}
				})

				if (res.status === 200 && res.statusText === 'OK') {
					videoName.value = res.data
					internalInstance.appContext.config.globalProperties.$Progress.finish()
					uploadFinished.value = 'Загружено'
					btnDisabled.value = false
				}
			}
			catch (e) {
				console.log(e.message)
			}
		}

		const onSelected = (e) => {
			const selectedGenre = e.target.value
			if (!genresArray.includes(selectedGenre)) {
				genresArray.push(selectedGenre)
			}
		}

		const submit = async () => {
			try {
				if(genresArray.length > 0) {
					genre.value = genresArray.join(',')
				}

				const data = {
					Title: title.value,
					TitleRomadzi: titleRomadzi.value,
					Rating: rating.value,
					Type: type.value,
					Description: description.value,
					Info: info.value,
					StudioId: Number(studio.value),
					Genres: genre.value,
					Image: imageName.value,
					Images: imagesNames.value,
					Teaser: videoName.value
				}

				const res = await axios.post('/api/anime', data)

				console.log(res)
			} 
			catch (e) {
				console.log(e.message)
			}
		}

		return {
			btnDisabled,
			uploadFinished,
			title,
			titleRomadzi,
			description,
			info,
			rating,
			type,
			studio,
			genre,
			imageName,
			imagesNames,
			videoName,
			handleImage,
			handleImages,
			handleVideo,
			onSelected,
			submit
		}
	}
}
</script>

<style>
button.disabled {
	cursor: not-allowed;
	pointer-events: all;
}
</style>